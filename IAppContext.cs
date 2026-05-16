using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms_client
{
    public interface IAppContext
    {
        void SwitchMainForm(KryptonForm newForm);
    }
}
