using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPacientes.Core.Application.Interfaces.Helpers
{
    public interface IPasswordEncryption
    {
        string ComputeSha256(string password);
    }
}
