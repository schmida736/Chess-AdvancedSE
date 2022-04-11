using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chess_AdvancedSE
{
    class Engine
    {
        private Process _engineProcess;
        private EngineTranslator _translator;
        public Engine(Game game)
        {
            this._translator = new(game);
            _Init();
            //_RunTask();
        }

        private void _Init(){
            _engineProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "StockFish.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true
                }
            };
        }

        private void _RunTask(){
            _engineProcess.Start();
            StringBuilder sb = new StringBuilder();
            var outStream = _engineProcess.StandardOutput;
            var inStream = _engineProcess.StandardInput;
            inStream.WriteLine("mkdir test");
            Task.Run(() =>
            {
                //tell the engine to use the UCI interface and set up the start position
                inStream.WriteLine("uci");
                inStream.WriteLine("ucinewgame");
                inStream.WriteLine("position startpos");
                while (!_engineProcess.HasExited)
                {
                    // send the current layout to the engine
                    inStream.WriteLine("position" + _translator.GetBoardLayout());

                    // let the engine calculate for 1 sec
                    inStream.WriteLine("go movetime 1000");

                    Thread.Sleep(1100);

                    // read out the currently calculated best move
                    _translator.RequestMove(outStream.ReadLine());
                }
            });
        }
    }
}
