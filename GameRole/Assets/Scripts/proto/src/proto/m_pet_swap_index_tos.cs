namespace proto {
	public class m_pet_swap_index_tos : Message
	{
		public int index1 = 0;
		public int index2 = 0;
		public m_pet_swap_index_tos() {
		}
		public override string getMethodName() {
			return "pet_swap_index";
		}
		public override string getClassName() {
			return "m_pet_swap_index_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index1", "int", "null"},new string[] {"index2", "int", "null"}};
		}
	}
}
