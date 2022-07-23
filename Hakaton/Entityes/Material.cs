namespace Hakaton.Entityes
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Amount { get; set; }

    }
}
