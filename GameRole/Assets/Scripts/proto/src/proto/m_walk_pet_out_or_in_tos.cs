namespace proto {
	public class m_walk_pet_out_or_in_tos : Message
	{
		public int op_type = 0;
		public m_walk_pet_out_or_in_tos() {
		}
		public override string getMethodName() {
			return "walk_pet_out_or_in";
		}
		public override string getClassName() {
			return "m_walk_pet_out_or_in_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
