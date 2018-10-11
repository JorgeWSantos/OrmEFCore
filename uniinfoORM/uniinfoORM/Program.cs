using System;
using uniinfo.Extensions;
using uniinfoORM.Controller;
using uniinfoORM.Model;

namespace uniinfoORM
{
    class Program
    {
        static void Main(string[] args)
        {
            UniinfoContext context = new UniinfoContext();
            context.LogSQLToConsole();

            foreach( var chamado in context.ChamadosAtendimento)
            {

            }

        }
    }
}
