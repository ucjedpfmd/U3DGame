namespace proto {
	public class m_pet_tower_challenge_tos : Message
	{
		public int op_type = 0;
		public int challenge_barrier = 0;
		public m_pet_tower_challenge_tos() {
		}
		public override string getMethodName() {
			return "pet_tower_challenge";
		}
		public override string getClassName() {
			return "m_pet_tower_challenge_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"challenge_barrier", "int", "null"}};
		}
	}
}
