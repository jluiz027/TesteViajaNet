using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SeleniumPlus.Util;

namespace ViajaNet.Test
{
    public class AoEntrarNaURL
    {
        [Fact]
        public void CarregaPagina()
        {
            var url = "http://localhost:4200";
            var webDriver = SeleniumPlus.DriverFactory.GetLocalChromeDriver();

            try
            {
                webDriver.TryNavigateToUrl(3, 1, url, "localhost");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                webDriver.Quit();
            }

        }
    }
}
