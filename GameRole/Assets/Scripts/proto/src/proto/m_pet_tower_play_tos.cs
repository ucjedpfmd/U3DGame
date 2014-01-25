namespace proto {
	public class m_pet_tower_play_tos : Message
	{
		public int barrier = 0;
		public m_pet_tower_play_tos() {
		}
		public override string getMethodName() {
			return "pet_tower_play";
		}
		public override string getClassName() {
			return "m_pet_tower_play_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"barrier", "int", "null"}};
		}
	}
}
