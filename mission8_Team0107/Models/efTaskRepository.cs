namespace mission8_Team0107.Models
{
    public class efTaskRepository : iTaskRepository
    {
        private TaskContext _context;

        public efTaskRepository(TaskContext context)
        {
            _context = context;
        }

        public List<TaskEntity> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public void AddTask(TaskEntity task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void RemoveTask(TaskEntity task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }

        public void UpdateTask(TaskEntity task) 
        { 
            _context.Update(task);
            _context.SaveChanges();
        }
    }
}
