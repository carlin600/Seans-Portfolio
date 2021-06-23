using System;

namespace KanbanConsoleApp
{
    public static class Assert
    {
        public static void AreEqual(int left, int right)
        {
            if (left != right)
                throw new Exception("Values are not equal");
        }

        public static void AreEqual(string left, string right)
        {
            if (left != right)
                throw new Exception("Values are not equal");
        }

        public static void AreEqual(bool left, bool right)
        {
            if (left != right)
                throw new Exception("Values are not equal");
        }

        public static Exception Throws(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                return exception;
            }

            throw new Exception("No exception thrown!");
        }
    }
}