namespace proto {
	public class m_pet_embattle_tos : Message
	{
		public int op_type = 0;
		public int type_id = 0;
		public int barrier = 0;
		public m_pet_embattle_tos() {
		}
		public override string getMethodName() {
			return "pet_embattle";
		}
		public override string getClassName() {
			return "m_pet_embattle_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"barrier", "int", "null"}};
		}
	}
}
