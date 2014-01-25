namespace proto {
	public class m_tx_gold_info_tos : Message
	{
		public int gold_type = 0;
		public m_tx_gold_info_tos() {
		}
		public override string getMethodName() {
			return "tx_gold_info";
		}
		public override string getClassName() {
			return "m_tx_gold_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"gold_type", "int", "null"}};
		}
	}
}
