using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventAsync
{
    public class AutoResetEventAsync
    {
        private bool _init_sw;
        private AutoResetEvent _event;
        private CancellationTokenSource _token_source;
        private CancellationToken _token;
        private int _waitting_cnt = 0;
        private bool _canceled = false;

        public AutoResetEventAsync(bool init)
        {
            _init_sw = init;
            _event = new AutoResetEvent(init);
            _token_source = new CancellationTokenSource();
            _token = _token_source.Token;
        }

        /// <summary>
        /// eventがsetされるのを待つ
        /// </summary>
        /// <returns>途中でキャンセルされたらfalse</returns>
        public async Task<bool> Wait()
        {
            Task<bool> task;
            lock (this)
            {
                var tkn = _token;
                task = Task<bool>.Run(() => {
                    lock (this)
                    {
                        ++ _waitting_cnt;
                    }
                    bool exit = false;
                    while (exit == false)
                    {
                        if(tkn.IsCancellationRequested) {
                            break; 
                        }
                        exit = _event.WaitOne(50);
                    }
                    lock (this)
                    {
                        -- _waitting_cnt;
                    }
                    return exit;
                });
            }
            return await task;
        }

        /// <summary>
        /// eventをset
        /// </summary>
        public void Set()
        {
            _event.Set();
        }

        /// <summary>
        /// キャンセル
        /// </summary>
        public void Cancel()
        {
            lock (this)
            {
                _canceled = true;
                _token_source.Cancel();
            }
            // 全てのTaskがキャンセルされるのを待つ
            while (_waitting_cnt > 0)
            {
                Thread.Sleep(100);
            }
        }

        public void Reset()
        {
            if (_canceled == false)
            {
                Cancel();
            }
            lock (this)
            {
                _token_source.Dispose();
                _canceled = false;
                _token_source = new CancellationTokenSource();
                _token = _token_source.Token;
                if (_init_sw)
                {
                    _event.Set();
                }
                else
                {
                    _event.Reset();
                }
            }
        }
        public bool isCanceled()
        {
            return _canceled;
        }
    }
}
