﻿using System;


namespace Infrastructure
{
    public class BaseRepository
    {
        protected DataBaseContext db = null;
        protected BaseRepository()
        {
            db = new DataBaseContext();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
