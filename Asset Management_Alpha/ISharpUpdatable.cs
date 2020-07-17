using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace Asset_Management_Alpha
{
    public interface ISharpUpdatable
    {
        string  ApplicationName { get; }
        string  ApplicationID { get; }
        Assembly ApplicationAssembly { get; }
        Icon ApplicationIcon { get; }
        Uri UpdateXmlLocation { get; }
        Form context { get; }
    }
}
