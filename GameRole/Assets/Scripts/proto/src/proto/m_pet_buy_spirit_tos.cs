namespace proto {
	public class m_pet_buy_spirit_tos : Message
	{
		public int optype = 0;
		public m_pet_buy_spirit_tos() {
		}
		public override string getMethodName() {
			return "pet_buy_spirit";
		}
		public override string getClassName() {
			return "m_pet_buy_spirit_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"optype", "int", "null"}};
		}
	}
}
