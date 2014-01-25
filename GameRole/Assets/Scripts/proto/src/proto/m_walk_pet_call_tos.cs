namespace proto {
	public class m_walk_pet_call_tos : Message
	{
		public int op_type = 0;
		public double pet_id = 0;
		public m_walk_pet_call_tos() {
		}
		public override string getMethodName() {
			return "walk_pet_call";
		}
		public override string getClassName() {
			return "m_walk_pet_call_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
