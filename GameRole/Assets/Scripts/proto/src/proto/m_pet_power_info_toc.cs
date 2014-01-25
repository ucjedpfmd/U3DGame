namespace proto {
	public class m_pet_power_info_toc : Message
	{
		public double pet_id = 0;
		public object[] power_infos;
		public m_pet_power_info_toc() {
		}
		public override string getMethodName() {
			return "pet_power_info";
		}
		public override string getClassName() {
			return "m_pet_power_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"power_infos", "array", "p_power_info"}};
		}
	}
}
