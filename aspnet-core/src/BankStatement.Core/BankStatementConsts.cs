using BankStatement.Debugging;

namespace BankStatement
{
    public class BankStatementConsts
    {
        public const string LocalizationSourceName = "BankStatement";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f58a3aec45ed431fb6fb10a6f4ed1daf";
    }
}
