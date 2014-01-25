namespace proto {
	public class m_pet_tower_auto_tos : Message
	{
		public int op_type = 0;
		public int auto_barrier = 0;
		public bool notice = true;
		public bool fail_stop = true;
		public m_pet_tower_auto_tos() {
		}
		public override string getMethodName() {
			return "pet_tower_auto";
		}
		public override string getClassName() {
			return "m_pet_tower_auto_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"auto_barrier", "int", "null"},new string[] {"notice", "bool", "null"},new string[] {"fail_stop", "bool", "null"}};
		}
	}
}
