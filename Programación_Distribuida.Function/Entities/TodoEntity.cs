using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace Programación_Distribuida.Function.Entities
{
    public class TodoEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescripcion { get; set; }

        public bool IsCompleted { get; set; }

    }
}
