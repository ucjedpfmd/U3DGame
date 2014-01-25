namespace proto {
	public class m_marry_propose_request_tos : Message
	{
		public double oppo_id = 0;
		public m_marry_propose_request_tos() {
		}
		public override string getMethodName() {
			return "marry_propose_request";
		}
		public override string getClassName() {
			return "m_marry_propose_request_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"oppo_id", "double", "null"}};
		}
	}
}
