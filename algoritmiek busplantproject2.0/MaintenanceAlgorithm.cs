using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algoritmiek_busplantproject2._0
{
    public class MaintenanceAlgorithm
    {
        public void mastermasteryannick(Bus bus)
        {
            MasterRensteester(bus);

        }
        public void MasterRensteester(Bus barry)
        {
            DateTime Datum = DateTime.Now;
            decimal tryingdiehard = (barry.Id - 1) / 6;
            // Vier seizoenen (3 maanden)
            for (int i = 0; i < 4; i++)
            {
                MaintenanceTask task = new MaintenanceTask();
                // Kleine reparatie beurten eens in de drie maanden
                task.PlannedDate = Datum.AddMonths((i * 3) + (barry.Id - 1) % 3).AddDays((int)Math.Floor(tryingdiehard));
                task.type = MaintenanceType.ShortMaintenance;
            }
        }

        public void Long_Maintenance(Bus baraabus)
        {
            DateTime Datum = DateTime.Now;
            MaintenanceTask LongTask = new MaintenanceTask();
            LongTask.type = MaintenanceType.LongMaintenance;
            LongTask.PlannedDate = Datum.AddMonths((baraabus.Id - 1) % 12);
            while (!Idontcare(LongTask.PlannedDate))
                LongTask.PlannedDate = LongTask.PlannedDate.AddDays(1);
            baraabus.Tasks.Add(LongTask);
        }
        public bool Idontcare(DateTime PlannedDate)
        {
            //call database for that if something exist
            return true;
        }

        
    }
}
