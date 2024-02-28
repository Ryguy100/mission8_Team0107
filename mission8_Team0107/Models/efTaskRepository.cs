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

        public void AddTask(TaskEntity task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}
