using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Exceptions {
    public class ElementModifyException : Exception {
        public ElementModifyException(string message) : base(message) {

        }
    }
}
