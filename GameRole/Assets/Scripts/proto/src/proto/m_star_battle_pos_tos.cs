namespace proto {
	public class m_star_battle_pos_tos : Message
	{
		public double role_id = 0;
		public m_star_battle_pos_tos() {
		}
		public override string getMethodName() {
			return "star_battle_pos";
		}
		public override string getClassName() {
			return "m_star_battle_pos_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
