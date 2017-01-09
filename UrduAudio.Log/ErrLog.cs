using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace UrduAudio.Log
{
    public class ErrLog
    {

        private static readonly ILog Log =
                LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogDefaultError(string errorString)
        {

            Log.Fatal(errorString);


        }
        public static void LogWarning(string errorString)
        {


            Log.Warn(errorString);


        }

        public static void LogInfo(string errorString)
        {


            Log.Info(errorString);


        }

        public static void LogDebug(string errorString)
        {


            Log.Debug(errorString);


        }

    }

}
