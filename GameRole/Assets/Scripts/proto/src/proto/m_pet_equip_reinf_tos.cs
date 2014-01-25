namespace proto {
	public class m_pet_equip_reinf_tos : Message
	{
		public double pet_id = 0;
		public int equip_id = 0;
		public int times = 0;
		public m_pet_equip_reinf_tos() {
		}
		public override string getMethodName() {
			return "pet_equip_reinf";
		}
		public override string getClassName() {
			return "m_pet_equip_reinf_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"equip_id", "int", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
