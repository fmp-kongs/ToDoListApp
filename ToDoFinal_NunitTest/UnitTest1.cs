using ToDoFinal;

namespace ToDoFinal_NunitTest
{
    public class Tests
    {

        private todoManager _todomanager { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _todomanager = new todoManager();
        }

        [Test]
        public void addTask_Test1()
        {

            //assign
            // act
            //assert
            _todomanager.addTask();

        }
        [Test]
        public void loadTaskFromFile_test()
        {
            _todomanager.loadTaskFromFile();
        }

        [Test]
        public void remove_test()
        {
            _todomanager.removeTask();
        }


    }
}