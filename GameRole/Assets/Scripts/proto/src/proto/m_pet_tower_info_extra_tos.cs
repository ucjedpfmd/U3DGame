namespace proto {
	public class m_pet_tower_info_extra_tos : Message
	{
		public int op_type = 0;
		public m_pet_tower_info_extra_tos() {
		}
		public override string getMethodName() {
			return "pet_tower_info_extra";
		}
		public override string getClassName() {
			return "m_pet_tower_info_extra_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
