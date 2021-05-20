using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace algoritmiek_busplantproject2._0
{
    public class Bus
    {
        public int Id { get; set; }
        public List<MaintenanceTask> Tasks { get; set; }

        public Bus(int id)
        {
            Tasks = new List<MaintenanceTask>();
            Id = id;
        }

    }
}
