using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBlazor.Data
{
    public interface IDataObject
    {
        public Guid GetPrimaryKey();
        public void Update();
        public void Delete();
        public Type GetObjectType();
    }

    //foreach class in 'Objects.cs'
    public partial class Guest : IDataObject
    {
        public Guid GetPrimaryKey()
        {
            return this.GuestId;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public Type GetObjectType()
        {
            return typeof(Guest);
        }
    }

    public partial class Session : IDataObject
    {
        public Guid GetPrimaryKey()
        {
            return this.SessionId;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public Type GetObjectType()
        {
            return typeof(Session);
        }
    }

    public partial class Instructor : IDataObject
    {
        public Guid GetPrimaryKey()
        {
            return this.InstructorId;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public Type GetObjectType()
        {
            return typeof(Instructor);
        }
    }

    public partial class Exercise : IDataObject
    {
        public Guid GetPrimaryKey()
        {
            return this.ExerciseId;
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public Type GetObjectType()
        {
            return typeof(Exercise);
        }
    }

}
