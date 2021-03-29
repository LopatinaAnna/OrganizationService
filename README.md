# OrganizationService

Working with the .NET SDK assemblies to work with data using Microsoft Dataverse.
The console application connects to the Organization service using the CrmServiceClient class and
implements entity operations using the Organization service.

# OrganizationService_Task

Deactivate old Orders and Order Plans:
<ul>
  <li>Get all Order Plans where Estimated Finish Date is less than today</li>
  <li>Go through all the retrieved Order Plans</li>
  <li>Get all Orders which are related to the current Order Plan</li>
  <li>Go through all the retrieved Orders</li>
  <li>Deactivate them(set “statecode” field to “Inactive”)</li>
  <li>Deactivate current Order Plan(set “statecode” field to “Inactive”)</li>
</ul>

# WorkWithSolutions

Entity service:
<ul>
  <li>AddNewEntity</li>
  <li>AddExistingEntity</li>
  <li>AddExistingComponentToSolution</li>
  <li>AddNewOptionSet</li>
  <li>CreateEntityRecord</li>
</ul>

Publisher service:
<ul>
  <li>RetrieveTheDefaultPublisher</li>
  <li>RetrievePublisher</li>
  <li>CreatePublisher</li>
</ul>

Solution service:
<ul>
  <li>RetrieveSolution</li>
  <li>CreateSolution</li>
  <li>DeleteSolution</li>
</ul>
