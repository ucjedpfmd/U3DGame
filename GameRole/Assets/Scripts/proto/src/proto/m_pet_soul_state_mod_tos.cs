namespace proto {
	public class m_pet_soul_state_mod_tos : Message
	{
		public int index = 0;
		public m_pet_soul_state_mod_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_state_mod";
		}
		public override string getClassName() {
			return "m_pet_soul_state_mod_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"}};
		}
	}
}
