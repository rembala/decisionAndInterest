﻿using DecisionAndInterestApplication.Common.Constants;
using DecisionAndInterestApplication.Interfaces.Helpers;
using DecisionAndInterestApplication.Interfaces.Repositories;
using DecisionAndInterestDomain.Entities;

namespace DecisionAndInterestApplication.Helpers
{
    public class DecisionHelper : IDecisionHelper
    {
        private readonly IDecisionRepository _decisionRepository;

        public DecisionHelper(IDecisionRepository decisionRepository)
        {
            _decisionRepository = decisionRepository;
        }

        public async Task<Decision> GetDecisionBasedOnAppliedAmountAsync(int amount)
        {
            var decisions =  _decisionRepository
                .GetDecisions()
                .ToDictionary(key => key.Title, decision => decision.Title);

            var decision = GetDecision(amount, decisions);

            return await Task.FromResult(new Decision { Title = decision });
        }

        private string GetDecision(int amount, Dictionary<string, string> decisions) {
            switch (amount)
            {
                case > 69000:
                    return decisions[DecisionConstants.No];

                case < 2000:
                    return decisions[DecisionConstants.No];

                case < 69000:
                case > 2000:
                    return decisions[DecisionConstants.Yes];
            }
        }
    }
}