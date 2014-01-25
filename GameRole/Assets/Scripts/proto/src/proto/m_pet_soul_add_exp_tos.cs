namespace proto {
	public class m_pet_soul_add_exp_tos : Message
	{
		public int index = 0;
		public int add_exp = 0;
		public m_pet_soul_add_exp_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_add_exp";
		}
		public override string getClassName() {
			return "m_pet_soul_add_exp_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"},new string[] {"add_exp", "int", "null"}};
		}
	}
}
