using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expo1
{
	class ControladorLucesInvoker:IInvoker
	{
		ICommand command;

		public void SetCommand(ICommand command)
		{
			this.command = command;
		}

		public void Invoke()
		{
			command.Execute();
		}
	}
}
