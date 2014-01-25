namespace proto {
	public class m_cross_miss_accpet_tos : Message
	{
		public int miss_id = 0;
		public m_cross_miss_accpet_tos() {
		}
		public override string getMethodName() {
			return "cross_miss_accpet";
		}
		public override string getClassName() {
			return "m_cross_miss_accpet_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"miss_id", "int", "null"}};
		}
	}
}
