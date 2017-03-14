using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ExtentReport.SeleniumUteis
{
    public class SeleniumConstantes
    {

        public const string BrowserExecucao = "chrome";

        // Urls do sistema
        public const string urlBase = "https://testmoz.com/1";

        // Especificar o diretorio do windows para salvar logs.
        public static string diretorioLogsRaiz = @"c:\LogsSelenium\";
        public static string diretorioFolderLog = @"C:\LogsSelenium\Log\";
        public static string diretorioFolderPrint = @"c:\LogsSelenium\Printscreen\";
        public static string diretorioServerPrint = @"\\wvci001\LogsSelenium\Printscreen\";
        public static string arquivoExtentConfig = @"\extent-config.xml";
        public static string diretorioDeployPrint = @"http:\\wvciweb001\Printscreen\";
        //public static string diretorioDeployPrint = "./LogsSeleniumB2/Printscreen/";


    }
}
