namespace proto {
	public class m_pet_equip_extra_tos : Message
	{
		public double pet_id = 0;
		public int equip_id = 0;
		public int op_type = 0;
		public object[] lock_ids;
		public m_pet_equip_extra_tos() {
		}
		public override string getMethodName() {
			return "pet_equip_extra";
		}
		public override string getClassName() {
			return "m_pet_equip_extra_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"equip_id", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"lock_ids", "array", "int"}};
		}
	}
}
