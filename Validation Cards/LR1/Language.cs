using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LR1
{
    internal static class Language
    {
        internal static List<CultureInfo> GetAvailableCultures()
        {
            var res = new List<CultureInfo>();

            foreach (var culture in Properties.Settings1.Default.Culture)
            {
                res.Add(CultureInfo.CreateSpecificCulture(culture));
            }
            res.Add(CultureInfo.InvariantCulture);
            return res;
        }
        internal static List<string> GetAvailableLanguages(List<CultureInfo> cultures)
        {
            var res = new List<string>();
            var current = CultureInfo.CurrentCulture;
            foreach (var culture in cultures)
            {
                SetCurrent(culture);
                res.Add(Properties.Resource.Resource.Language);
            }
            SetCurrent(current);
            return res;
        }
        internal static void SetCurrent(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
