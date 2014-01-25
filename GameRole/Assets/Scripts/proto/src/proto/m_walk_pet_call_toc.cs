namespace proto {
	public class m_walk_pet_call_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public double pet_id = 0;
		public m_walk_pet_call_toc() {
		}
		public override string getMethodName() {
			return "walk_pet_call";
		}
		public override string getClassName() {
			return "m_walk_pet_call_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
