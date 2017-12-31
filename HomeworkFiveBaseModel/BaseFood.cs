

namespace HomeworkFiveBaseModel
{
    public abstract class BaseFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Show();
    }
}
