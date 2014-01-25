namespace proto {
	public class m_equip_info_tos : Message
	{
		public double target_id = 0;
		public int equip_id = 0;
		public m_equip_info_tos() {
		}
		public override string getMethodName() {
			return "equip_info";
		}
		public override string getClassName() {
			return "m_equip_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_id", "double", "null"},new string[] {"equip_id", "int", "null"}};
		}
	}
}
