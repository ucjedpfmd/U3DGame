namespace proto {
	public class m_pet_equip_load_tos : Message
	{
		public int equipid = 0;
		public double pet_id = 0;
		public m_pet_equip_load_tos() {
		}
		public override string getMethodName() {
			return "pet_equip_load";
		}
		public override string getClassName() {
			return "m_pet_equip_load_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"equipid", "int", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
