﻿namespace ToDoApp.Constants
{
    public struct Db
    {
        public static string DB_PATH
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, "tarefas.db3");
            }
        }

    }

}
