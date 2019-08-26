namespace EntityFrameWorkCore.Data
{
    /// <summary>
    /// Representation of table row
    /// </summary>
    public class SettingsModel
    {
        /// <summary>
        /// The unique Id for this entity
        /// </summary>
        public string Id { get; set; }
        public string Name{ get; set; }
        public string Value { get; set; }
    }
}