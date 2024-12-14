using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN {
    public class Logger: ILogger {
        private static Logger _instance;

        private string _logFileName;
        private int _logId;
        private Stack<string> _namespaces;

        public static ILogger create() {
            if (_instance is null) {
                _instance = new Logger();
            }
            return _instance;
        }

        private Logger() {
            _logFileName = @$"{Directory.GetCurrentDirectory()}/LOG{DateTime.Now:yyyyMMdd-HH-mm-ss}.txt";
            _logId = 0;
            _namespaces = new Stack<string>();

            writeLog("INIT");
        }

        public void start(string title) {
            _namespaces.Push(title);
            writeLog("STRT");
        }

        public void stop() {
            _namespaces.Pop();
            writeLog("STOP");
        }

        public void log(string message) {
            writeLog("INFO", message);
        }

        private void writeLog(string logType, string message = "") {
            _logId++;
            File.AppendAllText(_logFileName, $"{formatLog(logType, message)}\n");
        }

        private string formatLog(string logType, string message = "") {
            return $"{_logId:d6}-{DateTime.Now:dd.MM.yyyy HH:mm:ss}-{logType} {formatNamespace()} {message}";
        }

        private string formatNamespace() {
            if (_namespaces.Count == 0) {
                return "";
            }
            return string.Join(":", _namespaces.ToArray().Reverse()) + ":";
        }
    }
}
