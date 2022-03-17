using System.Collections.Generic;

namespace ExamFunc
{
    class ItemPicker<T>
    {
        public static T PickTable(List<T> Tables)
        {   
            var clientTable = ItemSelecter.SelectItem(Tables);          
            return clientTable;
        }
    }
}
