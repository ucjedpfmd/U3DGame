namespace proto {
	public class m_role_pkmodemodify_tos : Message
	{
		public int pk_mode = 0;
		public m_role_pkmodemodify_tos() {
		}
		public override string getMethodName() {
			return "role_pkmodemodify";
		}
		public override string getClassName() {
			return "m_role_pkmodemodify_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pk_mode", "int", "null"}};
		}
	}
}
