namespace proto {
	public class m_pet_skill_preview_reward_tos : Message
	{
		public int reward_serial = 0;
		public m_pet_skill_preview_reward_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_preview_reward";
		}
		public override string getClassName() {
			return "m_pet_skill_preview_reward_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"reward_serial", "int", "null"}};
		}
	}
}
