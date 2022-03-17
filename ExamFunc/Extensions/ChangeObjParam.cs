
namespace ExamFunc
{
    public static class ChangeObjParam
    {             
        public static void ChangeTableVacancy(this Table obj)
        {
            if (obj != null)
            {
                obj.IsVacant = !obj.IsVacant;
            }
        }
    }
}
