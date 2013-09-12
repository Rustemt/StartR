﻿using StartR.Lib.Commands;
using StartR.Lib.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartR.Lib.Handlers
{
    public class QualifyNewClientCommandHandler : IHandler<QualifyNewClientCommand>
    {
        public void Handle(QualifyNewClientCommand command, Action completion)
        {
            Console.WriteLine(command);
            if (completion != null) completion();
        }
    }
}
