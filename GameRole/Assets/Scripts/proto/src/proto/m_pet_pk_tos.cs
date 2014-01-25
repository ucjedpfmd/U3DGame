namespace proto {
	public class m_pet_pk_tos : Message
	{
		public int op_type = 0;
		public double oppo_role_id = 0;
		public m_pet_pk_tos() {
		}
		public override string getMethodName() {
			return "pet_pk";
		}
		public override string getClassName() {
			return "m_pet_pk_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"oppo_role_id", "double", "null"}};
		}
	}
}
