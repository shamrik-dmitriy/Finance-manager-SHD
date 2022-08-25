namespace FM.SHDML.Core.Models.Users
{
    public interface IUserModel
    {
        /// <summary>
        ///     Идентификатор
        /// </summary>
        public long Id { get; set; }   
        
        /// <summary>
        ///     Наименование
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///     Пароль
        /// </summary>
        public string Password { get; set; }
    }
}