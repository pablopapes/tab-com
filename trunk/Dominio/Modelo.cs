using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Validations.Results;
using Dominio.Validations;

namespace Dominio
{
    public class Modelo<T> where T : Modelo<T>, new()
    {
        protected  ModelValidator<T> _validator;
        protected virtual ModelValidator<T> Validator { get; set; }
        public virtual int Id { get; protected set; }

        public override bool Equals(object obj)
        {
            Type objType = obj.GetType();
            Type thisType = this.GetType();
            if (obj == null) return false;


            Modelo<T> specificObject = obj as Modelo<T>;
            if (specificObject == null) return false;

            if (Id != specificObject.Id) return false;

            return true;

        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ 5;
        }

        public virtual ValidationResult Validate()
        {
            return (Validator != null) ? Validator.Validate((T)this) : new ValidationResult();
        }
    }
}
