namespace proto {
	public class m_pet_pearl_move_tos : Message
	{
		public int from_index = 0;
		public int to_index = 0;
		public m_pet_pearl_move_tos() {
		}
		public override string getMethodName() {
			return "pet_pearl_move";
		}
		public override string getClassName() {
			return "m_pet_pearl_move_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"from_index", "int", "null"},new string[] {"to_index", "int", "null"}};
		}
	}
}
