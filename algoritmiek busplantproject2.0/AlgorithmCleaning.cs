using System;
using System.Collections.Generic;
using System.Text;

namespace algoritmiek_busplantproject2._0
{
    public class AlgorithmCleaning : IDisposable
    {
        public void Dispose()
        {
        }

        public void renstester(Bus bus)
        {
            DateTime Datum = DateTime.Now;

            for (int i = 0; i < 60; i++)
            {
                MaintenanceTask Task = new MaintenanceTask();
                // Voeg het aantal dagen toe op basis van de huidige week en dag
                Task.PlannedDate = Datum.AddDays((i * 7) + ((bus.Id - 1) % 7));
                if (Task.PlannedDate.Year > Datum.Year)
                    break;
                Task.type = i % 3 == (bus.Id - 1) % 3
                    ? MaintenanceType.LongCleaning
                    : MaintenanceType.ShortCleaning;
                bus.Tasks.Add(Task);
            }
        }

    }
}
